// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The project details.</para>
        /// </summary>
        [NameInMap("ProjectInfo")]
        [Validation(Required=false)]
        public GetProjectResponseBodyProjectInfo ProjectInfo { get; set; }
        public class GetProjectResponseBodyProjectInfo : TeaModel {
            /// <summary>
            /// <para>The dependent data module display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务板块显示名</para>
            /// </summary>
            [NameInMap("BizUnitDisplayName")]
            [Validation(Required=false)]
            public string BizUnitDisplayName { get; set; }

            /// <summary>
            /// <para>The dependent data module ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务板块Id</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The compute source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目依赖计算源Id</para>
            /// </summary>
            [NameInMap("ComputeSourceId")]
            [Validation(Required=false)]
            public long? ComputeSourceId { get; set; }

            /// <summary>
            /// <para>The compute source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目依赖计算源名</para>
            /// </summary>
            [NameInMap("ComputeSourceName")]
            [Validation(Required=false)]
            public string ComputeSourceName { get; set; }

            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project for xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The project display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目显示名</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703048484000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703048484000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12356</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The project mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC</description></item>
            /// <item><description>DEV_PROD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("NameSpaceTag")]
            [Validation(Required=false)]
            public string NameSpaceTag { get; set; }

            /// <summary>
            /// <para>The project owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101111</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The project owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The stream compute source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目依赖实时计算源Id</para>
            /// </summary>
            [NameInMap("StreamComputeSourceId")]
            [Validation(Required=false)]
            public long? StreamComputeSourceId { get; set; }

            /// <summary>
            /// <para>The stream compute source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目依赖实时计算源名</para>
            /// </summary>
            [NameInMap("StreamComputeSourceName")]
            [Validation(Required=false)]
            public string StreamComputeSourceName { get; set; }

            /// <summary>
            /// <para>The project type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The whitelists.</para>
            /// </summary>
            [NameInMap("WhiteLists")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyProjectInfoWhiteLists> WhiteLists { get; set; }
            public class GetProjectResponseBodyProjectInfoWhiteLists : TeaModel {
                /// <summary>
                /// <para>The whitelist description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist for xxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.209.47.198</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
