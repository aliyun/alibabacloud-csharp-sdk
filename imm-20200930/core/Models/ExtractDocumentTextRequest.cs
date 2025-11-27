// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ExtractDocumentTextRequest : TeaModel {
        /// <summary>
        /// <para><b>If there are no special requirements, leave it blank.</b></para>
        /// <para>Chain authorization configuration, optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Using Chain Authorization to Access Other Entity Resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>Project name. For how to obtain it, see <a href="https://help.aliyun.com/document_detail/477051.html">Creating a Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Suffix type of the source data. By default, the type of the source data is determined based on the suffix of the input object. When the input object does not have a suffix, you can set this parameter. The available values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Word Documents: doc, docx, wps, wpss, docm, dotm, dot, dotx, html</description></item>
        /// <item><description>Presentation Documents (PPT): pptx, ppt, pot, potx, pps, ppsx, dps, dpt, pptm, potm, ppsm, dpss</description></item>
        /// <item><description>Spreadsheet Documents (Excel): xls, xlt, et, ett, xlsx, xltx, csv, xlsb, xlsm, xltm, ets</description></item>
        /// <item><description>PDF Documents: pdf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>docx</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Storage address of the source data.</para>
        /// <para>The OSS address rule is oss://${Bucket}/${Object}, where <c>${Bucket}</c> is the name of the OSS Bucket in the same region (Region) as the current project, and <c>${Object}</c> is the complete path of the file including the file extension.</para>
        /// <remarks>
        /// <para>Notice: Currently, only HTTP protocol addresses are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

    }

}
