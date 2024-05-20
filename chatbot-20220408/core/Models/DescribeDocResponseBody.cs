// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeDocResponseBody : TeaModel {
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("DocInfo")]
        [Validation(Required=false)]
        public DescribeDocResponseBodyDocInfo DocInfo { get; set; }
        public class DescribeDocResponseBodyDocInfo : TeaModel {
            [NameInMap("DocParas")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocInfoDocParas> DocParas { get; set; }
            public class DescribeDocResponseBodyDocInfoDocParas : TeaModel {
                [NameInMap("ParaLevel")]
                [Validation(Required=false)]
                public int? ParaLevel { get; set; }

                [NameInMap("ParaNo")]
                [Validation(Required=false)]
                public int? ParaNo { get; set; }

                [NameInMap("ParaText")]
                [Validation(Required=false)]
                public string ParaText { get; set; }

                [NameInMap("ParaType")]
                [Validation(Required=false)]
                public string ParaType { get; set; }

            }

        }

        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("DocTags")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocTags> DocTags { get; set; }
        public class DescribeDocResponseBodyDocTags : TeaModel {
            [NameInMap("DefaultTag")]
            [Validation(Required=false)]
            public bool? DefaultTag { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public long? ModifyUserId { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("ProcessCanRetry")]
        [Validation(Required=false)]
        public bool? ProcessCanRetry { get; set; }

        [NameInMap("ProcessMessage")]
        [Validation(Required=false)]
        public string ProcessMessage { get; set; }

        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public int? ProcessStatus { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
