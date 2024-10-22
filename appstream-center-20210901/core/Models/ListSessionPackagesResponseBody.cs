// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListSessionPackagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSessionPackagesResponseBodyData> Data { get; set; }
        public class ListSessionPackagesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("AvailableHours")]
            [Validation(Required=false)]
            public long? AvailableHours { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeleteStatus")]
            [Validation(Required=false)]
            public int? DeleteStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701170196000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1701170203000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("InstanceObject")]
            [Validation(Required=false)]
            public ListSessionPackagesResponseBodyDataInstanceObject InstanceObject { get; set; }
            public class ListSessionPackagesResponseBodyDataInstanceObject : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-28T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tp-xxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>appstreaming.general.entry</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>p-xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AppSessionPackage</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-28T04:14:07Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3600000</para>
                /// </summary>
                [NameInMap("TotalTime")]
                [Validation(Required=false)]
                public long? TotalTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1021</para>
                /// </summary>
                [NameInMap("UsedTime")]
                [Validation(Required=false)]
                public long? UsedTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxHours")]
            [Validation(Required=false)]
            public long? MaxHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxSessions")]
            [Validation(Required=false)]
            public long? MaxSessions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tp-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("SessionPackageId")]
            [Validation(Required=false)]
            public string SessionPackageId { get; set; }

            [NameInMap("SessionPackageName")]
            [Validation(Required=false)]
            public string SessionPackageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SessionPackageTypeId")]
            [Validation(Required=false)]
            public string SessionPackageTypeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>appstreaming.general.entry</para>
            /// </summary>
            [NameInMap("SessionSpec")]
            [Validation(Required=false)]
            public string SessionSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SessionUsageRate")]
            [Validation(Required=false)]
            public long? SessionUsageRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>156xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserIdentification")]
            [Validation(Required=false)]
            public long? UserIdentification { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5Fxxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
