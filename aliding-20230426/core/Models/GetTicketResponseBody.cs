// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTicketResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-07-09 14:45:01</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public GetTicketResponseBodyCreator Creator { get; set; }
        public class GetTicketResponseBodyCreator : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>贤文</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UnionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input1&quot;,&quot;name&quot;: &quot;正文&quot;,&quot;placeholder&quot;: &quot;请输入&quot;,&quot;required&quot;: false,&quot;type&quot;: &quot;TEXT_AREA&quot;,&quot;value&quot;: &quot;123&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input2&quot;,&quot;name&quot;: &quot;单选&quot;,&quot;options&quot;: [{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项1&quot;},{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项2&quot;},{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项3&quot;}],&quot;required&quot;: false,&quot;type&quot;: &quot;RADIO&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input3&quot;,&quot;name&quot;: &quot;多选&quot;,&quot;options&quot;: [{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项1&quot;},{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项2&quot;},{&quot;color&quot;: &quot;#000000&quot;,&quot;value&quot;: &quot;选项3&quot;}],&quot;required&quot;: false,&quot;type&quot;: &quot;CHECKBOX&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input5&quot;,&quot;name&quot;: &quot;数字&quot;,&quot;required&quot;: false,&quot;type&quot;: &quot;INPUT_NUMBER&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input6&quot;,&quot;maxFileNum&quot;: 20,&quot;name&quot;: &quot;上传&quot;,&quot;required&quot;: false,&quot;type&quot;: &quot;FILE&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;identifier&quot;: &quot;input7&quot;,&quot;maxFileNum&quot;: 20,&quot;name&quot;: &quot;图片&quot;,&quot;required&quot;: false,&quot;type&quot;: &quot;IMAGE&quot;},{&quot;customerVisible&quot;: true,&quot;editable&quot;: false,&quot;format&quot;: &quot;DATE_TIME&quot;,&quot;identifier&quot;: &quot;input8&quot;,&quot;name&quot;: &quot;日期&quot;,&quot;required&quot;: false,&quot;type&quot;: &quot;DATE_TIME_PICKER&quot;}]</para>
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidZBSNxxxxXUCrAA==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a8iSxxxxtgiE</para>
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        [NameInMap("processor")]
        [Validation(Required=false)]
        public GetTicketResponseBodyProcessor Processor { get; set; }
        public class GetTicketResponseBodyProcessor : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>贤文</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UnionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SG</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;groupId&quot;:1893227,&quot;groupIsNormal&quot;:true,&quot;groupName&quot;:&quot;API和SPI测试群&quot;,&quot;groupSetId&quot;:29003,&quot;groupSetName&quot;:&quot;默认服务群组&quot;,&quot;scene&quot;:&quot;SG&quot;}</para>
        /// </summary>
        [NameInMap("sceneContext")]
        [Validation(Required=false)]
        public string SceneContext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("takers")]
        [Validation(Required=false)]
        public List<GetTicketResponseBodyTakers> Takers { get; set; }
        public class GetTicketResponseBodyTakers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>贤文</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>012345</para>
            /// </summary>
            [NameInMap("UnionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("template")]
        [Validation(Required=false)]
        public GetTicketResponseBodyTemplate Template { get; set; }
        public class GetTicketResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>OpenTemplateBizId</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenTemplateBizId</para>
            /// </summary>
            [NameInMap("OpenTemplateBizId")]
            [Validation(Required=false)]
            public string OpenTemplateBizId { get; set; }

            /// <summary>
            /// <para>OpenTemplateBizId</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenTemplateBizId</para>
            /// </summary>
            [NameInMap("OpenTemplateId")]
            [Validation(Required=false)]
            public string OpenTemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>贤文api测试，处理人王鸿程和李航宇</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-07-09 19:26:09</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
