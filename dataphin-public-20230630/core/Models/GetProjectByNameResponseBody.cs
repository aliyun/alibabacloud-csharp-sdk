// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetProjectByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
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
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The project details.</para>
        /// </summary>
        [NameInMap("ProjectInfo")]
        [Validation(Required=false)]
        public GetProjectByNameResponseBodyProjectInfo ProjectInfo { get; set; }
        public class GetProjectByNameResponseBodyProjectInfo : TeaModel {
            /// <summary>
            /// <para>The display name of the business unit to which the project belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("BizUnitDisplayName")]
            [Validation(Required=false)]
            public string BizUnitDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the business unit to which the project belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101131</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the associated compute source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101711</para>
            /// </summary>
            [NameInMap("ComputeSourceId")]
            [Validation(Required=false)]
            public long? ComputeSourceId { get; set; }

            /// <summary>
            /// <para>The name of the associated compute source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds1</para>
            /// </summary>
            [NameInMap("ComputeSourceName")]
            [Validation(Required=false)]
            public string ComputeSourceName { get; set; }

            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The environment identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The creation time, in the format of yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time, in the format of yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-10 10:01:01</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1030111021</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The project mode.</para>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: public type</description></item>
            /// <item><description>APPLICATION: application type</description></item>
            /// <item><description>BASE: base type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASE</para>
            /// </summary>
            [NameInMap("NameSpaceTag")]
            [Validation(Required=false)]
            public string NameSpaceTag { get; set; }

            /// <summary>
            /// <para>The project owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The project owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>The ID of the associated real-time compute source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201711</para>
            /// </summary>
            [NameInMap("StreamComputeSourceId")]
            [Validation(Required=false)]
            public long? StreamComputeSourceId { get; set; }

            /// <summary>
            /// <para>The name of the associated real-time compute source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds2</para>
            /// </summary>
            [NameInMap("StreamComputeSourceName")]
            [Validation(Required=false)]
            public string StreamComputeSourceName { get; set; }

            /// <summary>
            /// <para>The project type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DISTILL: distillation project</description></item>
            /// <item><description>GENERAL: general project.</description></item>
            /// </list>
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
            public List<GetProjectByNameResponseBodyProjectInfoWhiteLists> WhiteLists { get; set; }
            public class GetProjectByNameResponseBodyProjectInfoWhiteLists : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx 白名单</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Ip</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.11.1.21</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5432</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
