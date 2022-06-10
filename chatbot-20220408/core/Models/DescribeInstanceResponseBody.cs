// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// 机器人头像的URL
        /// </summary>
        [NameInMap("Avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 类目列表
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<DescribeInstanceResponseBodyCategories> Categories { get; set; }
        public class DescribeInstanceResponseBodyCategories : TeaModel {
            /// <summary>
            /// 类目id
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// 类目名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 父类目id，-1表示根目录
            /// </summary>
            [NameInMap("ParentCategoryId")]
            [Validation(Required=false)]
            public long? ParentCategoryId { get; set; }

        }

        /// <summary>
        /// 机器人创建的 UTC 时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 机器人状态： EDITING(编辑中)、 PUBLISHED(已发布)
        /// </summary>
        [NameInMap("EditStatus")]
        [Validation(Required=false)]
        public string EditStatus { get; set; }

        /// <summary>
        /// 机器人唯一标识
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 机器人备注
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 机器人服务的语言，如zh-cn、en-us
        /// </summary>
        [NameInMap("LanguageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// 机器人名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 机器人类型
        /// </summary>
        [NameInMap("RobotType")]
        [Validation(Required=false)]
        public string RobotType { get; set; }

        /// <summary>
        /// 机器人的时区，参考《公共-时区码》
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
