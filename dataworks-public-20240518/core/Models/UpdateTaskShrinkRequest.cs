// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Task_0bc5213917368545132902xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientUniqueCode")]
        [Validation(Required=false)]
        public string ClientUniqueCode { get; set; }

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public string DependenciesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string InputsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>T+1</para>
        /// </summary>
        [NameInMap("InstanceMode")]
        [Validation(Required=false)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string OutputsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RerunInterval")]
        [Validation(Required=false)]
        public int? RerunInterval { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllAllowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RerunTimes")]
        [Validation(Required=false)]
        public int? RerunTimes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

        [NameInMap("Script")]
        [Validation(Required=false)]
        public string ScriptShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
