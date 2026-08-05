// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include secret versions that do not have version stages in the response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not include</description></item>
        /// <item><description>true: includes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDeprecated")]
        [Validation(Required=false)]
        public string IncludeDeprecated { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The secret name or secret Amazon Resource Name (ARN).</para>
        /// <remarks>
        /// <para>When accessing a secret under another Alibaba Cloud account, you must specify the secret ARN. The format of the secret ARN is <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
