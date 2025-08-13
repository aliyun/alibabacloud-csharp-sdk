// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateModelRequest : TeaModel {
        /// <summary>
        /// <para>Submitter ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WB01160353</para>
        /// </summary>
        [NameInMap("BucId")]
        [Validation(Required=false)]
        public string BucId { get; set; }

        /// <summary>
        /// <para>Number of file rows.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Counts")]
        [Validation(Required=false)]
        public string Counts { get; set; }

        /// <summary>
        /// <para>File MD5 value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VC6Sj3u138yfWHLxLl7dtA==</para>
        /// </summary>
        [NameInMap("FileMD5")]
        [Validation(Required=false)]
        public string FileMD5 { get; set; }

        /// <summary>
        /// <para>File path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tempCache/ef2387dfb357ffe87925fd51d2b5305b/1665717035328/mockData.csv</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>Model name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Model scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf_ai_account_abuse</para>
        /// </summary>
        [NameInMap("ModelScene")]
        [Validation(Required=false)]
        public string ModelScene { get; set; }

        /// <summary>
        /// <para>Number of file columns.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ParameterNum")]
        [Validation(Required=false)]
        public string ParameterNum { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Uploaded file name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fileTest</para>
        /// </summary>
        [NameInMap("UserLocalFileName")]
        [Validation(Required=false)]
        public string UserLocalFileName { get; set; }

    }

}
