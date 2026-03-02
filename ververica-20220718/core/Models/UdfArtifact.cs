// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfArtifact : TeaModel {
        /// <summary>
        /// <para>The type of the JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ARTIFACT_TYPE_JAVA</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The time when the JAR file was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723532876</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The user that creates the JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userA</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The list of paths in which the additional dependencies of the JAR file are stored.</para>
        /// </summary>
        [NameInMap("dependencyJarUris")]
        [Validation(Required=false)]
        public List<string> DependencyJarUris { get; set; }

        /// <summary>
        /// <para>The path in which the JAR file is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/udfCollection.jar</para>
        /// </summary>
        [NameInMap("jarUrl")]
        [Validation(Required=false)]
        public string JarUrl { get; set; }

        /// <summary>
        /// <para>The time when the JAR file was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723537876</para>
        /// </summary>
        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        /// <summary>
        /// <para>The name of the JAR file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>udfCollection.jar</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The list of the class name of the JAR file.</para>
        /// </summary>
        [NameInMap("udfClasses")]
        [Validation(Required=false)]
        public List<UdfClass> UdfClasses { get; set; }

    }

}
