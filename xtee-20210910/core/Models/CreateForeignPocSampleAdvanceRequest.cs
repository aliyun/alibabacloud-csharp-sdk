// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateForeignPocSampleAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>OSS path of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saf/cpoc/953c883cde33b2e21d722eb661d26375/1779172027996_自动回溯测试 2605191.csv</para>
        /// </summary>
        [NameInMap("File")]
        [Validation(Required=false)]
        public Stream FileObject { get; set; }

        /// <summary>
        /// <para>Set the language type for requests and received messages. Default value is <b>zh</b>. Valid values:</para>
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
        /// <para>Area encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nemo-test</para>
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
        /// <para>FINANCE</para>
        /// </summary>
        [NameInMap("Tab")]
        [Validation(Required=false)]
        public string Tab { get; set; }

    }

}
