// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProjectWorkitemTypesResponseBody : TeaModel {
        /// <summary>
        /// 错误返回码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误返回信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// openapi平台的request id
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 接口是否正常返回
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 工作项类型
        /// </summary>
        [NameInMap("workitemTypes")]
        [Validation(Required=false)]
        public List<ListProjectWorkitemTypesResponseBodyWorkitemTypes> WorkitemTypes { get; set; }
        public class ListProjectWorkitemTypesResponseBodyWorkitemTypes : TeaModel {
            /// <summary>
            /// 添加到项目中的添加人
            /// </summary>
            [NameInMap("addUser")]
            [Validation(Required=false)]
            public string AddUser { get; set; }

            /// <summary>
            /// 工作项类型
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// 工作项类型创建人
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 在项目中是否为默认类型
            /// </summary>
            [NameInMap("defaultType")]
            [Validation(Required=false)]
            public bool? DefaultType { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 是否启用
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// 添加到项目中的时间
            /// </summary>
            [NameInMap("gmtAdd")]
            [Validation(Required=false)]
            public long? GmtAdd { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 工作项类型id
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 工作项类型的名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 工作项类型的英文名称
            /// </summary>
            [NameInMap("nameEn")]
            [Validation(Required=false)]
            public string NameEn { get; set; }

            /// <summary>
            /// 是否系统默认
            /// </summary>
            [NameInMap("systemDefault")]
            [Validation(Required=false)]
            public bool? SystemDefault { get; set; }

        }

    }

}
