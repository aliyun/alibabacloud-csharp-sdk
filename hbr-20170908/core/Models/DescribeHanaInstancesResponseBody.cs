// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Hanas")]
        [Validation(Required=false)]
        public DescribeHanaInstancesResponseBodyHanas Hanas { get; set; }
        public class DescribeHanaInstancesResponseBodyHanas : TeaModel {
            [NameInMap("Hana")]
            [Validation(Required=false)]
            public List<DescribeHanaInstancesResponseBodyHanasHana> Hana { get; set; }
            public class DescribeHanaInstancesResponseBodyHanasHana : TeaModel {
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                [NameInMap("HanaName")]
                [Validation(Required=false)]
                public string HanaName { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeHanaInstancesResponseBodyHanasHanaTags Tags { get; set; }
                public class DescribeHanaInstancesResponseBodyHanasHanaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeHanaInstancesResponseBodyHanasHanaTagsTag> Tag { get; set; }
                    public class DescribeHanaInstancesResponseBodyHanasHanaTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("UseSsl")]
                [Validation(Required=false)]
                public bool? UseSsl { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("ValidateCertificate")]
                [Validation(Required=false)]
                public bool? ValidateCertificate { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4003DD68-3C3C-5071-B4FC-631A6C1BAC1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
