// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The business status of the project. You can typically ignore this parameter for standard cloud editing projects. Use this parameter to modify the project\&quot;s reservation status:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Reserving</c>: The project is being reserved.</para>
        /// </description></item>
        /// <item><description><para><c>ReservationCanceled</c>: The reservation for the project is canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Reserving</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The clip parameters for the template, in JSON format. This parameter is required if you specify <c>TemplateId</c>.&lt;props=&quot;china&quot;&gt; For more information about the format, see <a href="https://help.aliyun.com/document_detail/328557.html">Create and use a standard template</a> and <a href="https://help.aliyun.com/document_detail/291418.html">Create and use an advanced template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>See the template user guide.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The project cover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.com/6AB4D0E1E1C7446888</b></b>.png</para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The project description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline001desciption</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>4ee4b97e27b525142a6b2</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The template ID. Use this parameter to quickly build a timeline.&gt;Notice: You can specify only one of <c>ProjectId</c>, <c>Timeline</c>, and <c>TemplateId</c>. If you specify <c>TemplateId</c>, <c>ClipsParam</c> is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The project timeline, in JSON format.</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The project title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
