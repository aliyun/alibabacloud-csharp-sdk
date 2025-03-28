// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemEstimateResponseBody : TeaModel {
        [NameInMap("WorkitemTimeEstimate")]
        [Validation(Required=false)]
        public CreateWorkitemEstimateResponseBodyWorkitemTimeEstimate WorkitemTimeEstimate { get; set; }
        public class CreateWorkitemEstimateResponseBodyWorkitemTimeEstimate : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>deafe5f33xxxxx6a259d8dafd</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("recordUser")]
            [Validation(Required=false)]
            public CreateWorkitemEstimateResponseBodyWorkitemTimeEstimateRecordUser RecordUser { get; set; }
            public class CreateWorkitemEstimateResponseBodyWorkitemTimeEstimateRecordUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1316458xxxxx41068</para>
                /// </summary>
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200">https://tcs-devops.aliyuncs.com/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fdsad12xxx11</para>
                /// </summary>
                [NameInMap("dingTalkId")]
                [Validation(Required=false)]
                public string DingTalkId { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wangwu</para>
                /// </summary>
                [NameInMap("displayNickName")]
                [Validation(Required=false)]
                public string DisplayNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wangwu</para>
                /// </summary>
                [NameInMap("displayRealName")]
                [Validation(Required=false)]
                public string DisplayRealName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:xxxxxxcc@xxx.com">xxxxxxcc@xxx.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deafe5f33xxxxx6a259d8dafd</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("isDisabled")]
                [Validation(Required=false)]
                public bool? IsDisabled { get; set; }

                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wangwu</para>
                /// </summary>
                [NameInMap("nameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wangwu</para>
                /// </summary>
                [NameInMap("nickNamePinyin")]
                [Validation(Required=false)]
                public string NickNamePinyin { get; set; }

                [NameInMap("realName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wangwu</para>
                /// </summary>
                [NameInMap("realNamePinyin")]
                [Validation(Required=false)]
                public string RealNamePinyin { get; set; }

                [NameInMap("stamp")]
                [Validation(Required=false)]
                public string Stamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
                /// </summary>
                [NameInMap("tbRoleId")]
                [Validation(Required=false)]
                public string TbRoleId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("spentTime")]
            [Validation(Required=false)]
            public long? SpentTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1e9903d8b3f1xxxxxf9286ef5</para>
            /// </summary>
            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
