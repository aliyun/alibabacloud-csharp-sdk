// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The business status of the project. This parameter can be ignored for general editing projects. You can modify the reservation status of the project. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Reserving: The project is being reserved.</description></item>
        /// <item><description>ReservationCanceled: The reservation is canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Reserving</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The material parameters for the template in JSON format. If TemplateId is specified, ClipsParam must also be specified.&lt;props=&quot;china&quot;&gt;For more information about the format, see <a href="https://help.aliyun.com/document_detail/328557.html">Create and use a common template</a> and <a href="https://help.aliyun.com/document_detail/291418.html">Create and use an advanced template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>See the template user guide.</para>
        /// </summary>
        [NameInMap("ClipsParam")]
        [Validation(Required=false)]
        public string ClipsParam { get; set; }

        /// <summary>
        /// <para>The cover URL of the cloud editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.com/6AB4D0E1E1C7446888</b></b>.png</para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The description of the cloud editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline001desciption</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the cloud editing project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>4ee4b97e27b525142a6b2</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The template ID, which is used to quickly build a timeline with minimal effort.&gt;Notice: Exactly one of ProjectId, Timeline, and TemplateId must be specified. If TemplateId is specified, ClipsParam must also be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The timeline of the cloud editing project in JSON format.</para>
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// <para>The title of the cloud editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testtimeline</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
