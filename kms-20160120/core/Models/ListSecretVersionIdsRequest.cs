// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include credential versions that have no version stages in the response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No</para>
        /// </description></item>
        /// <item><description><para>true: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDeprecated")]
        [Validation(Required=false)]
        public string IncludeDeprecated { get; set; }

        /// <summary>
        /// <para>The number of the page to return for a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name or Alibaba Cloud Resource Name (ARN) of the credential.</para>
        /// <remarks>
        /// <para>When you access a credential that belongs to another Alibaba Cloud account, you must specify the ARN of the credential. The ARN of a credential is in the format of <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
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
