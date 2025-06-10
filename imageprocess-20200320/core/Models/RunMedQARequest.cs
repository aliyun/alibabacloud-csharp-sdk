// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQARequest : TeaModel {
        [NameInMap("AnswerImageDataList")]
        [Validation(Required=false)]
        public List<RunMedQARequestAnswerImageDataList> AnswerImageDataList { get; set; }
        public class RunMedQARequestAnswerImageDataList : TeaModel {
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
        public List<RunMedQARequestAnswerImageURLList> AnswerImageURLList { get; set; }
        public class RunMedQARequestAnswerImageURLList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/imageprocess/roseola.jpeg">https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/imageprocess/roseola.jpeg</a></para>
            /// </summary>
            [NameInMap("AnswerImageURL")]
            [Validation(Required=false)]
            public string AnswerImageURL { get; set; }

        }

        [NameInMap("AnswerTextList")]
        [Validation(Required=false)]
        public List<RunMedQARequestAnswerTextList> AnswerTextList { get; set; }
        public class RunMedQARequestAnswerTextList : TeaModel {
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
