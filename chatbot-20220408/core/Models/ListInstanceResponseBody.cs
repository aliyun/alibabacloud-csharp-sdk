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
            /// <para>The time when the chatbot was created. The time is in the UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The unique ID of the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-mp90s2lrk00050</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The remarks on the chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用于C端问答的机器人</para>
            /// </summary>
            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            /// <summary>
            /// <para>The language of the chatbot, such as zh-cn and en-us. For more information, see http\://www\.lingoes.net/en/translator/langcode.htm.</para>
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
            /// <para>智能客服-小C</para>
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
