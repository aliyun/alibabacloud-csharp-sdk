// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAuthorityTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission templates.</para>
        /// </summary>
        [NameInMap("AuthorityTemplateViewList")]
        [Validation(Required=false)]
        public ListAuthorityTemplateResponseBodyAuthorityTemplateViewList AuthorityTemplateViewList { get; set; }
        public class ListAuthorityTemplateResponseBodyAuthorityTemplateViewList : TeaModel {
            [NameInMap("AuthorityTemplateView")]
            [Validation(Required=false)]
            public List<ListAuthorityTemplateResponseBodyAuthorityTemplateViewListAuthorityTemplateView> AuthorityTemplateView { get; set; }
            public class ListAuthorityTemplateResponseBodyAuthorityTemplateViewListAuthorityTemplateView : TeaModel {
                /// <summary>
                /// <para>The time when the permission template was created. The time is in the yyyy-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-26 11:37:47</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the permission template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>522****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public long? CreatorId { get; set; }

                /// <summary>
                /// <para>The description of the permission template.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the permission template.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the permission template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2592</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31853A2B-DC9D-5B39-8492-D2AC8BCF550E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The total number of permission templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
