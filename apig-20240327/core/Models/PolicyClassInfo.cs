// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyClassInfo : TeaModel {
        /// <summary>
        /// <para>The alias of the policy template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concurrency Control</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The list of resource types that can be mounted.</para>
        /// </summary>
        [NameInMap("attachableResourceTypes")]
        [Validation(Required=false)]
        public List<string> AttachableResourceTypes { get; set; }

        /// <summary>
        /// <para>The identifier of the policy template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-cpqm0s94ckt1displ8ng</para>
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        /// <summary>
        /// <para>The configuration example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("configExample")]
        [Validation(Required=false)]
        public string ConfigExample { get; set; }

        /// <summary>
        /// <para>Indicates whether the policy is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("deprecated")]
        [Validation(Required=false)]
        public bool? Deprecated { get; set; }

        /// <summary>
        /// <para>The detailed description of the policy template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Controls the number of concurrent threads to ensure system stability. Applicable to scenarios where internal application components or downstream dependencies become unstable, such as slow SQL queries or increased response time from downstream applications</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The direction in which the policy takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Indicates whether log recording is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableLog")]
        [Validation(Required=false)]
        public bool? EnableLog { get; set; }

        /// <summary>
        /// <para>The execution priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public string ExecutePriority { get; set; }

        /// <summary>
        /// <para>The execution stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POST</para>
        /// </summary>
        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        /// <summary>
        /// <para>The name of the policy template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConcurrencyLimit</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The version of the policy template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
