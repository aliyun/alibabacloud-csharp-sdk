// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAAdvanceRequest : TeaModel {
        [NameInMap("AnswerImageDataList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerImageDataList> AnswerImageDataList { get; set; }
        public class RunMedQAAdvanceRequestAnswerImageDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>iVBORw0KGgoAAAANSUhEUgAAAoAAAAHJCAIAAACaEB9NAAEAAElEQVR4nNT9Wb****</para>
            /// </summary>
            [NameInMap("AnswerImageData")]
            [Validation(Required=false)]
            public string AnswerImageData { get; set; }

        }

        [NameInMap("AnswerImageURLList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerImageURLList> AnswerImageURLList { get; set; }
        public class RunMedQAAdvanceRequestAnswerImageURLList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/imageprocess/roseola.jpeg">https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/imageprocess/roseola.jpeg</a></para>
            /// </summary>
            [NameInMap("AnswerImageURL")]
            [Validation(Required=false)]
            public Stream AnswerImageURLObject { get; set; }

        }

        [NameInMap("AnswerTextList")]
        [Validation(Required=false)]
        public List<RunMedQAAdvanceRequestAnswerTextList> AnswerTextList { get; set; }
        public class RunMedQAAdvanceRequestAnswerTextList : TeaModel {
            [NameInMap("AnswerText")]
            [Validation(Required=false)]
            public string AnswerText { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0001</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weiyi</para>
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chiefComplaint</para>
        /// </summary>
        [NameInMap("QuestionType")]
        [Validation(Required=false)]
        public string QuestionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d1f6a6c2444f4c01adfadd413938e5c7</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
