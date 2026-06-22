// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Binding : TeaModel {
        /// <summary>
        /// <para>The timestamp when the binding between the dataset and the OSS bucket was created. The format is RFC3339Nano.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset001</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The scan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FullScanning: A full scan is in progress.</para>
        /// </description></item>
        /// <item><description><para>IncrementalScanning: An incremental scan is in progress.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullScanning</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Reason</para>
        /// 
        /// <b>Example:</b>
        /// <para>pause usage</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The state of the binding between the dataset and the OSS bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Ready: The binding is being prepared after it is created.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The binding is paused.</para>
        /// </description></item>
        /// <item><description><para>Running: The binding is running.</para>
        /// </description></item>
        /// <item><description><para>Retrying: The binding is being retried after it is created.</para>
        /// </description></item>
        /// <item><description><para>Failed: The binding failed to be created.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The binding is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The URI of the Object Storage Service (OSS) bucket attached to the dataset.</para>
        /// <para>The format of an OSS bucket URI is <c>oss://${bucketname}</c>. The <c>bucketname</c> is the name of an OSS bucket that is in the same region as the current project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// <para>The timestamp when the binding between the dataset and the OSS bucket was last modified. The format is RFC3339Nano.</para>
        /// <remarks>
        /// <para>After a binding is created, if the binding has not been paused or restarted, this timestamp is the same as the creation timestamp.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-29T14:50:13.011643661+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
