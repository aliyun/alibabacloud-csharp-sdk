// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateSecurityStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The policy content, which is constrained by the <c>SecurityStrategySchema</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para><b>The policy description.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>控制数据分析模块的查询结果安全行为</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>The policy ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para><b>The policy name.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>默认数据分析策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para><b>A list of associated workspace IDs.</b></para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public string WorkspacesShrink { get; set; }

    }

}
