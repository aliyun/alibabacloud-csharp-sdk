// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Revision : TeaModel {
        /// <summary>
        /// <para>The time when the revision version was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-09T14:24:42</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The description of the revision version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configurations of the revision version.</para>
        /// </summary>
        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        /// <summary>
        /// <para>The ID of the revision version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("RevisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The traffic weight of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public float? Weight { get; set; }

    }

}
