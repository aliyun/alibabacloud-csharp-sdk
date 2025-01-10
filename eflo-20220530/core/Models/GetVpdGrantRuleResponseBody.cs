// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVpdGrantRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetVpdGrantRuleResponseBodyContent Content { get; set; }
        public class GetVpdGrantRuleResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Lingjun HUB Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>er-kkopgtne</para>
            /// </summary>
            [NameInMap("ErId")]
            [Validation(Required=false)]
            public string ErId { get; set; }

            /// <summary>
            /// <para>Authorized Resource ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>grant-rule-xxxxxx</para>
            /// </summary>
            [NameInMap("GrantRuleId")]
            [Validation(Required=false)]
            public string GrantRuleId { get; set; }

            /// <summary>
            /// <para>Authorized Tenant ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620939556166277</para>
            /// </summary>
            [NameInMap("GrantTenantId")]
            [Validation(Required=false)]
            public string GrantTenantId { get; set; }

            /// <summary>
            /// <para>Network Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Network Instance Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-lingjun</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Network Product Code:</para>
            /// <list type="bullet">
            /// <item><description><b>VPD</b>: Lingjun CIDR block</description></item>
            /// <item><description><b>VCC</b>: Lingjun Connection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPD</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2l4sq6l7u***</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655449505171</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>Whether the current authorization information has been used; default is false</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public bool? Used { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C50C9CD-E799-54DA-BA7A-1FAF3DF80857</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
