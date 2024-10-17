// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The business status of the project. This parameter can be ignored for general editing projects. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Reserving</description></item>
        /// <item><description>ReservationCanceled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Reserving</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The material parameter corresponding to the template, in the JSON format. If TemplateId is specified, ClipsParam must also be specified. For more information&lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/document_detail/328557.html">Create and use a regular template</a> and <a href="https://help.aliyun.com/document_detail/291418.html">Create and use an advanced template</a>.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The thumbnail URL of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.com/6AB4D0E1E1C7446888</b></b>.png</para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline001desciption</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>4ee4b97e27b525142a6b2</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter is used to quickly build a timeline with ease. Note: Only one of ProjectId, Timeline, and TemplateId can be specified. If TemplateId is specified, ClipsParam must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
