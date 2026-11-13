// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class LineageRelationRegisterTaskVO : TeaModel {
        /// <summary>
        /// <para>Other task attributes</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>The time of lineage relation generation</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684327487964</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>All input entities</para>
        /// </summary>
        [NameInMap("InputEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> InputEntities { get; set; }

        /// <summary>
        /// <para>Task name</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai-task name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>All output entities</para>
        /// </summary>
        [NameInMap("OutputEntities")]
        [Validation(Required=false)]
        public List<LineageEntityVO> OutputEntities { get; set; }

        /// <summary>
        /// <para>Unique identifier of entity</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai_dlcjob-task.12304</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

    }

}
