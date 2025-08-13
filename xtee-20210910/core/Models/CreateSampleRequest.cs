// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateSampleRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>OSS client uploaded file name</para>
        /// 
        /// <b>Example:</b>
        /// <para>样本文件.csv</para>
        /// </summary>
        [NameInMap("clientFileName")]
        [Validation(Required=false)]
        public string ClientFileName { get; set; }

        /// <summary>
        /// <para>OSS client address</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample/path</para>
        /// </summary>
        [NameInMap("clientPath")]
        [Validation(Required=false)]
        public string ClientPath { get; set; }

        /// <summary>
        /// <para>File type</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSV</para>
        /// </summary>
        [NameInMap("fileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Sample tag</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm0102</para>
        /// </summary>
        [NameInMap("sampleTag")]
        [Validation(Required=false)]
        public string SampleTag { get; set; }

        /// <summary>
        /// <para>Sample type</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHONE</para>
        /// </summary>
        [NameInMap("sampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        /// <summary>
        /// <para>Sample values</para>
        /// 
        /// <b>Example:</b>
        /// <para>1777000000,1777000001</para>
        /// </summary>
        [NameInMap("sampleValues")]
        [Validation(Required=false)]
        public string SampleValues { get; set; }

        /// <summary>
        /// <para>Upload type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANNEX</para>
        /// </summary>
        [NameInMap("uploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

    }

}
