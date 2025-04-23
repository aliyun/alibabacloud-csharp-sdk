// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public GetInstanceListResponseBodyInstanceList InstanceList { get; set; }
        public class GetInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("InstanceVO")]
            [Validation(Required=false)]
            public List<GetInstanceListResponseBodyInstanceListInstanceVO> InstanceVO { get; set; }
            public class GetInstanceListResponseBodyInstanceListInstanceVO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1566215995000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public int? DeployType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.0.212:9092,192.168.0.210:9092,192.168.0.211:****</para>
                /// </summary>
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1568908800000</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-mp919o4v****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-mp919o4v****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>47.111.110.11:9093,121.40.96.141:9093,47.111.118.133:****</para>
                /// </summary>
                [NameInMap("SslEndPoint")]
                [Validation(Required=false)]
                public string SslEndPoint { get; set; }

                [NameInMap("UpgradeServiceDetailInfo")]
                [Validation(Required=false)]
                public GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo UpgradeServiceDetailInfo { get; set; }
                public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfo : TeaModel {
                    [NameInMap("UpgradeServiceDetailInfoVO")]
                    [Validation(Required=false)]
                    public List<GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfoUpgradeServiceDetailInfoVO> UpgradeServiceDetailInfoVO { get; set; }
                    public class GetInstanceListResponseBodyInstanceListInstanceVOUpgradeServiceDetailInfoUpgradeServiceDetailInfoVO : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.10</para>
                        /// </summary>
                        [NameInMap("Current2OpenSourceVersion")]
                        [Validation(Required=false)]
                        public string Current2OpenSourceVersion { get; set; }

                    }

                }

                /// <summary>
                /// <para>VSwitch ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp13rg6bcpkxofr78****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1l6hrlykj3405r7****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABA4A7FD-E10F-45C7-9774-A5236015****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
