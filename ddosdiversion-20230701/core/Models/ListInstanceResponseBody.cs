// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// - 200: The request was successful.
        /// - Other codes: The request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyData Data { get; set; }
        public class ListInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the anti-DDoS diversion instance.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyDataInstances> Instances { get; set; }
            public class ListInstanceResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The purchase time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The expiration time.
                /// </summary>
                [NameInMap("GmtExpire")]
                [Validation(Required=false)]
                public string GmtExpire { get; set; }

                /// <summary>
                /// The update time.
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// The alias of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The configurations of the instance.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// The specifications of the instance.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListInstanceResponseBodyDataInstancesSpec Spec { get; set; }
                public class ListInstanceResponseBodyDataInstancesSpec : TeaModel {
                    /// <summary>
                    /// The region of the asset.
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// The diversion mode. Valid values: on-demand always-on
                    /// </summary>
                    [NameInMap("DiversionType")]
                    [Validation(Required=false)]
                    public string DiversionType { get; set; }

                    /// <summary>
                    /// The mitigation plan.
                    /// </summary>
                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public string Edition { get; set; }

                    /// <summary>
                    /// The number of data centers. Valid values: 1 to 10.
                    /// </summary>
                    [NameInMap("IdcNumbers")]
                    [Validation(Required=false)]
                    public string IdcNumbers { get; set; }

                    /// <summary>
                    /// The initial installation mode.
                    /// </summary>
                    [NameInMap("InitialInstallation")]
                    [Validation(Required=false)]
                    public string InitialInstallation { get; set; }

                    /// <summary>
                    /// The initial installation quantity.
                    /// </summary>
                    [NameInMap("InitialQty")]
                    [Validation(Required=false)]
                    public string InitialQty { get; set; }

                    /// <summary>
                    /// The number of CIDR blocks. Value range: 1 to 10000.
                    /// </summary>
                    [NameInMap("IpSubnetNums")]
                    [Validation(Required=false)]
                    public string IpSubnetNums { get; set; }

                    /// <summary>
                    /// The mitigation analysis feature.
                    /// </summary>
                    [NameInMap("MitigationAnalysis")]
                    [Validation(Required=false)]
                    public string MitigationAnalysis { get; set; }

                    /// <summary>
                    /// The log storage capacity.
                    /// </summary>
                    [NameInMap("MitigationAnalysisCapacity")]
                    [Validation(Required=false)]
                    public string MitigationAnalysisCapacity { get; set; }

                    /// <summary>
                    /// The maximum mitigation capability.
                    /// </summary>
                    [NameInMap("MitigationCapacity")]
                    [Validation(Required=false)]
                    public string MitigationCapacity { get; set; }

                    /// <summary>
                    /// The number of mitigation sessions.
                    /// </summary>
                    [NameInMap("MitigationNums")]
                    [Validation(Required=false)]
                    public string MitigationNums { get; set; }

                    /// <summary>
                    /// The service traffic. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("NormalBandwidth")]
                    [Validation(Required=false)]
                    public string NormalBandwidth { get; set; }

                }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// - normal
                /// - expired
                /// - deleting
                /// - stopped
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
