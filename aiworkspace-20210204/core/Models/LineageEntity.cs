// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LineageEntity : TeaModel {
        /// <summary>
        /// <para>Attributes</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Path&quot;:&quot;training/data/&quot;,&quot;ResourceType&quot;:&quot;dataset&quot;,&quot;ResourceUse&quot;:&quot;train&quot;,&quot;RegionId&quot;:&quot;cn-hangzhou&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <para>The type of the data lineage entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-file</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The name of the data lineage entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>training-dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique qualified name of the data lineage entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.demo_project.training_data</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

    }

}
