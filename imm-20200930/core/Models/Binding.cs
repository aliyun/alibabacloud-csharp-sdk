// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Binding : TeaModel {
        /// <summary>
        /// <para>The RFC3339Nano timestamp when the OSS bucket was bound to the dataset.</para>
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
        /// <para>The type of the scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FullScanning</description></item>
        /// <item><description>IncrementalScanning</description></item>
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
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The status of the binding between the dataset and the OSS bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ready: IMM is ready to create the binding.</description></item>
        /// <item><description>Stopped: The binding creation is suspended.</description></item>
        /// <item><description>Running: The binding is running.</description></item>
        /// <item><description>Retrying: IMM is retrying the binding.</description></item>
        /// <item><description>Failed: The binding failed.</description></item>
        /// <item><description>Deleted: The binding is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The URI of the OSS bucket to which the dataset is bound.</para>
        /// <para>The URI is in the <c>oss://${bucketname}</c> format, where <c>bucketname</c> is the name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// <para>The RFC3339Nano timestamp when the binding was modified.</para>
        /// <remarks>
        /// <para> If you never suspend or retry the binding between the dataset and the OSS bucket after you complete the binding, the value of UpdateTime is the same as that of CreateTime.</para>
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
