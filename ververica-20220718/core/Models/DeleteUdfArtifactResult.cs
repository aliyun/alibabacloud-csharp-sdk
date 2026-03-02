// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeleteUdfArtifactResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether the JAR file was deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deleteSuccess")]
        [Validation(Required=false)]
        public bool? DeleteSuccess { get; set; }

        /// <summary>
        /// <para>The message used to delete the JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>All associated classes.</para>
        /// </summary>
        [NameInMap("referencedClasses")]
        [Validation(Required=false)]
        public List<UdfClass> ReferencedClasses { get; set; }

    }

}
