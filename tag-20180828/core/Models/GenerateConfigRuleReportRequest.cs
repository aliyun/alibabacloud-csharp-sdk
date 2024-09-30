// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GenerateConfigRuleReportRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>154950938137****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
        /// <item><description>ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ACCOUNT</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The mode of the Tag Policy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: single-account mode</description></item>
        /// <item><description>RD: multi-account mode</description></item>
        /// </list>
        /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
        /// <remarks>
        /// <para> This parameter is required if the management account of your resource directory is used to enable the Tag Policy feature in both single-account mode and multi-account mode. The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
