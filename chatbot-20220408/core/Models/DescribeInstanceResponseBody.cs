// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
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
        /// <para>The list of categories.</para>
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<DescribeInstanceResponseBodyCategories> Categories { get; set; }
        public class DescribeInstanceResponseBodyCategories : TeaModel {
            /// <summary>
            /// <para>The ability type of the category, such as FAQ (frequently asked questions) or MRC (document).</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAQ</para>
            /// </summary>
            [NameInMap("AbilityType")]
            [Validation(Required=false)]
            public string AbilityType { get; set; }

            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000066832</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pandemic Prevention Policy</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parent category ID. A value of -1 indicates the root directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

        }

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
        /// <para>The status of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISHED</para>
        /// </summary>
        [NameInMap("EditStatus")]
        [Validation(Required=false)]
        public string EditStatus { get; set; }

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
        /// <para>The remarks of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A chatbot for consumer Q&amp;A</para>
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>The language of the chatbot service, such as zh-cn or en-us.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>907AA5F2-0521-49AB-80AB-1ADEFAB2B901</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scenario_im</para>
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

        /// <summary>
        /// <para>The time zone of the chatbot. For more information, see the common time zone codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Chongqing</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
