// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreatePocSampleRequest : TeaModel {
        /// <summary>
        /// <para>File Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P4911_2707.csv</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>File URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/cpoc/953c883cde33b2e21d722eb661d26375/测试文件模板-通用.csv</para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The language of the error message returned by the API. Valid values: zh: Chinese. en: English. The default value is en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The area encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>The remark for the topic. It can only contain letters, digits, underscores (_), and hyphens (-). The length must be 3 to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-pub</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Sample Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleNameTest</para>
        /// </summary>
        [NameInMap("SampleName")]
        [Validation(Required=false)]
        public string SampleName { get; set; }

        /// <summary>
        /// <para>Scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

        /// <summary>
        /// <para>Access type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAF_CONSOLE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
