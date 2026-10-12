// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateSecurityStrategyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency parameter. This parameter is used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The policy content. The content is constrained by SecurityStrategySchema.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The control scope.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tenant</para>
        /// </summary>
        [NameInMap("ControlDwScope")]
        [Validation(Required=false)]
        public string ControlDwScope { get; set; }

        /// <summary>
        /// <para>The control module.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <para>The control submodule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Controls the security behavior of query results in the data analysis module</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default data analysis policy</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the schema template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataQuerySecurityStrategySchema</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The list of associated workspace IDs.</para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public string WorkspacesShrink { get; set; }

    }

}
