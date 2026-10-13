// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of chatbots.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyInstances> Instances { get; set; }
        public class ListInstanceResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The URL of the chatbot avatar.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/alimefe/meebot/robot/0.0.5/img/xxx-90-97.png</para>
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>The UTC time when the chatbot was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-mp90s2lrk00050</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The description of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A chatbot for consumer Q&amp;A</para>
            /// </summary>
            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// <para>The language of the chatbot service, such as zh-cn or en-us. For more information, see <a href="http://www.lingoes.net/zh/translator/langcode.htm">http://www.lingoes.net/zh/translator/langcode.htm</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-cn</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

            /// <summary>
            /// <para>The name of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Intelligent Customer Service - Bot C</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scenario_im</para>
            /// </summary>
            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public string RobotType { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92B81548-42B9-4B34-924B-4E778AEB412B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
