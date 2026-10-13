// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class SkillAddMetaProfilingJobRequest : TeaModel {
        /// <summary>
        /// <para>The component ID, which is the primary key identifier of the data source component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001</para>
        /// </summary>
        [NameInMap("componentId")]
        [Validation(Required=false)]
        public long? ComponentId { get; set; }

        /// <summary>
        /// <para>The description of the profiling task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily full metadata profiling task</para>
        /// </summary>
        [NameInMap("jobDesc")]
        [Validation(Required=false)]
        public string JobDesc { get; set; }

        /// <summary>
        /// <para>The profiling task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100256</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The name of the profiling task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>profiling_daily</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The list of metadata object IDs to be profiled or operated on.</para>
        /// </summary>
        [NameInMap("metaIds")]
        [Validation(Required=false)]
        public List<string> MetaIds { get; set; }

        /// <summary>
        /// <para>The profiling plugin ID, which specifies the plugin used to perform the profiling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>profiling-plugin-001</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data profiling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("profilingFlag")]
        [Validation(Required=false)]
        public int? ProfilingFlag { get; set; }

        /// <summary>
        /// <para>The profiling permission configuration identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("profilingPermission")]
        [Validation(Required=false)]
        public int? ProfilingPermission { get; set; }

        /// <summary>
        /// <para>The profiling rule configuration content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("profilingRule")]
        [Validation(Required=false)]
        public string ProfilingRule { get; set; }

        /// <summary>
        /// <para>The list of schemas to be profiled.</para>
        /// </summary>
        [NameInMap("profilingSchemaList")]
        [Validation(Required=false)]
        public List<string> ProfilingSchemaList { get; set; }

        /// <summary>
        /// <para>The profiling type identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("profilingType")]
        [Validation(Required=false)]
        public int? ProfilingType { get; set; }

    }

}
