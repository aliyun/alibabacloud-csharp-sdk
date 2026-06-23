// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSecurityStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures request idempotency, preventing duplicate operations if you retry the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The content of the strategy. This value is constrained by the <c>SecurityStrategySchema</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para><b>The control scope. Valid values: Workspace and Tenant.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tenant</para>
        /// </summary>
        [NameInMap("ControlDwScope")]
        [Validation(Required=false)]
        public string ControlDwScope { get; set; }

        /// <summary>
        /// <para><b>Control module</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <para><b>Control submodule</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <para><b>Strategy description</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>控制数据分析模块的查询结果安全行为</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>Strategy name</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认数据分析策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para><b>Schema template name</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuerySecurityStrategySchema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>A list of associated workspace IDs.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public string WorkspacesShrink { get; set; }

    }

}
