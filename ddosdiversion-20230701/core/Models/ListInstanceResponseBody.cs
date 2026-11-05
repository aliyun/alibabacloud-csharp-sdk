// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: The call is successful.</description></item>
        /// <item><description>Other values: An error code.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyData Data { get; set; }
        public class ListInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The array of diversion instance details.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyDataInstances> Instances { get; set; }
            public class ListInstanceResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// <para>The remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test instance.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The purchase time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-15 11:10:42</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-15 11:10:42</para>
                /// </summary>
                [NameInMap("GmtExpire")]
                [Validation(Required=false)]
                public string GmtExpire { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-15 11:10:42</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddos_diversion_public_cn-xxxxxxxxxxxxx_xxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The configuration information of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test instance.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the diversion instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddos_diversion_public_cn-xxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// <para>The specifications.</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListInstanceResponseBodyDataInstancesSpec Spec { get; set; }
                public class ListInstanceResponseBodyDataInstancesSpec : TeaModel {
                    /// <summary>
                    /// <para>The asset region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>international_and_hmt</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The diversion pattern. Valid values: on-demand and always-on.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on-demand</para>
                    /// </summary>
                    [NameInMap("DiversionType")]
                    [Validation(Required=false)]
                    public string DiversionType { get; set; }

                    /// <summary>
                    /// <para>The mitigation plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enterprise</para>
                    /// </summary>
                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public string Edition { get; set; }

                    /// <summary>
                    /// <para>The number of Internet Data Centers (IDCs). Valid values: 1 to 10.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IdcNumbers")]
                    [Validation(Required=false)]
                    public string IdcNumbers { get; set; }

                    /// <summary>
                    /// <para>The initial installation mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gre_tunnel_by_pccw</para>
                    /// </summary>
                    [NameInMap("InitialInstallation")]
                    [Validation(Required=false)]
                    public string InitialInstallation { get; set; }

                    /// <summary>
                    /// <para>The initial installation quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("InitialQty")]
                    [Validation(Required=false)]
                    public string InitialQty { get; set; }

                    /// <summary>
                    /// <para>The number of CIDR blocks (Class C). Valid values: 1 to 10000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IpSubnetNums")]
                    [Validation(Required=false)]
                    public string IpSubnetNums { get; set; }

                    /// <summary>
                    /// <para>The mitigation logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>off</para>
                    /// </summary>
                    [NameInMap("MitigationAnalysis")]
                    [Validation(Required=false)]
                    public string MitigationAnalysis { get; set; }

                    /// <summary>
                    /// <para>The mitigation log capacity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3T</para>
                    /// </summary>
                    [NameInMap("MitigationAnalysisCapacity")]
                    [Validation(Required=false)]
                    public string MitigationAnalysisCapacity { get; set; }

                    /// <summary>
                    /// <para>The maximum mitigation capability.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unlimited</para>
                    /// </summary>
                    [NameInMap("MitigationCapacity")]
                    [Validation(Required=false)]
                    public string MitigationCapacity { get; set; }

                    /// <summary>
                    /// <para>The number of mitigation sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unlimited</para>
                    /// </summary>
                    [NameInMap("MitigationNums")]
                    [Validation(Required=false)]
                    public string MitigationNums { get; set; }

                    /// <summary>
                    /// <para>The clean bandwidth. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("NormalBandwidth")]
                    [Validation(Required=false)]
                    public string NormalBandwidth { get; set; }

                }

                /// <summary>
                /// <para>The instance status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>normal: The instance is running normally.</description></item>
                /// <item><description>expired: The instance has expired.</description></item>
                /// <item><description>deleting: The instance is being deleted.</description></item>
                /// <item><description>stopped: The instance is stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>177xxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0949F09-B9C1-1D5E-8F27-0A5BF3CD5D95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
