// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class UpdateAppInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Application type</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>Business ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a unique value from your client for this parameter to guarantee uniqueness across different requests. ClientToken supports only ASCII characters and must not exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Deployment area</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChineseMainland</para>
        /// </summary>
        [NameInMap("DeployArea")]
        [Validation(Required=false)]
        public string DeployArea { get; set; }

        /// <summary>
        /// <para>Application description</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Extension information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;user_device_id\&quot;:\&quot;6bef45cb0c76de284d24de074c088b73\&quot;}\n</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Application icon</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1864953777494693/1753841032702_WX20250729-171155%402x.png">https://app-center-icon-prod-shanghai.oss-cn-shanghai.aliyuncs.com/tenant/1864953777494693/1753841032702_WX20250729-171155%402x.png</a></para>
        /// </summary>
        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// <para>Application name</para>
        /// 
        /// <b>Example:</b>
        /// <para>大角鹿</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Payment type</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_PAY</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3cqkrqibqkby</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Website version</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic_Edition</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public string SiteVersion { get; set; }

        /// <summary>
        /// <para>Tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateAppInstanceRequestTags> Tags { get; set; }
        public class UpdateAppInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values for N: <b>1</b> to <b>20</b>. If you specify this parameter, it cannot be an empty string.</para>
            /// <para>It can contain up to 64 characters, must not start with <c>aliyun</c> or <c>acs:</c>, and must not contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values for N: <b>1</b> to <b>20</b>. If you specify this parameter, it can be an empty string.</para>
            /// <para>It can contain up to 128 characters, must not start with <c>aliyun</c> or <c>acs:</c>, and must not contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>Application thumbnail</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("ThumbnailUrl")]
        [Validation(Required=false)]
        public string ThumbnailUrl { get; set; }

    }

}
