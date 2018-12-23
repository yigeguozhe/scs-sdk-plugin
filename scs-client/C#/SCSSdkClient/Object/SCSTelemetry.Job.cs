﻿#pragma warning disable 1570

namespace SCSSdkClient.Object {
    public partial class SCSTelemetry {
        /// <summary>
        ///     Job values. Income, destination, source, etc.
        /// </summary>
        public class Job {
            /// <summary>
            ///     Initialise a job object
            /// </summary>
            public Job() {
                DeliveryTime = new Time();
                RemainingDeliveryTime = new Frequency();
                CargoValues = new Cargo();
            }

            /// <summary>
            ///     In-game time to the moment the job delivery window close
            /// </summary>
            public Time DeliveryTime { get; internal set; }

            /// About: RemainingDeliveryTime
            /// The RemainingDeliveryTime is negative if the delivery is to late

            /// <summary>
            ///     Remaining in-game time until the job delivery window close
            /// </summary>
            /// <!---->
            /// **INFORMATION**
            /// <!---->
            /// Negative if the delivery is to late
            /// <!---->
            /// **INFORMATION**
            /// <!---->
            public Frequency RemainingDeliveryTime { get; protected internal set; }

            /// <summary>
            ///     Vargo values of an job
            /// </summary>
            public Cargo CargoValues { get; internal set; }

            /// <summary>
            ///     Id of the destination city for internal use by code.
            ///     Limited to C-identifier characters and dots.
            /// </summary>
            public string CityDestinationId { get; internal set; }

            /// <summary>
            ///     Name of the destination city for display purposes.
            ///     Localized using the current in-game language.
            /// </summary>
            public string CityDestination { get; internal set; }

            /// <summary>
            ///     Id of the destination company for internal use by code.
            ///     Limited to C-identifier characters and dots.
            /// </summary>
            public string CompanyDestinationId { get; internal set; }

            /// <summary>
            ///     Name of the destination company for display purposes.
            ///     Localized using the current in-game language.
            /// </summary>
            public string CompanyDestination { get; internal set; }

            /// <summary>
            ///     Id of the source city for internal use by code.
            ///     Limited to C-identifier characters and dots.
            /// </summary>
            public string CitySourceId { get; internal set; }

            /// <summary>
            ///     Name of the source city for display purposes.
            ///     Localized using the current in-game language.
            /// </summary>
            public string CitySource { get; internal set; }

            /// <summary>
            ///     Id of the source company for internal use by code.
            ///     Limited to C-identifier characters and dots.
            /// </summary>
            public string CompanySourceId { get; internal set; }

            /// <summary>
            ///     Name of the source company for display purposes.
            ///     Localized using the current in-game language.
            /// </summary>
            public string CompanySource { get; internal set; }

            /// <summary>
            ///     Reward in internal game-specific currency.
            /// </summary>
            public long Income { get; internal set; }

            /// <summary>
            ///     Cargo Values
            /// </summary>
            public class Cargo {
                /// <summary>
                ///     Mass in kilograms
                /// </summary>
                public float Mass { get; internal set; }

                /// <summary>
                ///     Name for internal use by code.
                ///     Limited to C-identifier characters and dots.
                /// </summary>
                public string Id { get; internal set; }

                /// <summary>
                ///     Name for display purposes.
                ///     Localized using the current in-game language.
                /// </summary>
                public string Name { get; internal set; }

                /// <summary>
                ///     Name of cargo accessory for internal use by code.
                ///     Limited to C-identifier characters and dots.
                /// </summary>
                public string AccessoryId { get; internal set; }
            }
        }
    }
}