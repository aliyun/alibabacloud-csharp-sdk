// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateUdfArtifactResult : TeaModel {
        /// <summary>
        /// <para>All classes in conflict.</para>
        /// </summary>
        [NameInMap("collidingClasses")]
        [Validation(Required=false)]
        public List<UdfClass> CollidingClasses { get; set; }

        /// <summary>
        /// <para>Indicates whether the JAR file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("createSuccess")]
        [Validation(Required=false)]
        public bool? CreateSuccess { get; set; }

        /// <summary>
        /// <para>The message used to create the JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The JAR file that you created.</para>
        /// </summary>
        [NameInMap("udfArtifact")]
        [Validation(Required=false)]
        public UdfArtifact UdfArtifact { get; set; }

    }

}
