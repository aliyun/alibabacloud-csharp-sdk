// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDocParserJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the document to be parsed.</para>
        /// <remarks>
        /// <para>The name must include the file name extension. Currently, only .pdf is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS URL of the document to be parsed.</para>
        /// <remarks>
        /// <para>This parameter is automatically populated when you call this operation by using an SDK.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/storage/pdf/40184458-fbb0-44cf-a391-350628ceccdd17375122">https://oss-cn-hangzhou.aliyuncs.com/storage/pdf/40184458-fbb0-44cf-a391-350628ceccdd17375122</a>****</para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("RagInstanceId")]
        [Validation(Required=false)]
        public string RagInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the document parsing task. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The output format of the parsing result after the task is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zip</b>: a ZIP compressed file.</description></item>
        /// <item><description><b>content</b>: plain text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zip</para>
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

    }

}
