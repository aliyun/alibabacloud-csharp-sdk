// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ProjectInfo")]
        [Validation(Required=false)]
        public GetProjectResponseBodyProjectInfo ProjectInfo { get; set; }
        public class GetProjectResponseBodyProjectInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("BizUnitDisplayName")]
            [Validation(Required=false)]
            public string BizUnitDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101131</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101711</para>
            /// </summary>
            [NameInMap("ComputeSourceId")]
            [Validation(Required=false)]
            public long? ComputeSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds1</para>
            /// </summary>
            [NameInMap("ComputeSourceName")]
            [Validation(Required=false)]
            public string ComputeSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project for xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1703048484000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1703048484000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12356</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dp_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("NameSpaceTag")]
            [Validation(Required=false)]
            public string NameSpaceTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101111</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>201711</para>
            /// </summary>
            [NameInMap("StreamComputeSourceId")]
            [Validation(Required=false)]
            public long? StreamComputeSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds2</para>
            /// </summary>
            [NameInMap("StreamComputeSourceName")]
            [Validation(Required=false)]
            public string StreamComputeSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WhiteLists")]
            [Validation(Required=false)]
            public List<GetProjectResponseBodyProjectInfoWhiteLists> WhiteLists { get; set; }
            public class GetProjectResponseBodyProjectInfoWhiteLists : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>whitelist for xxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>ip</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.209.47.198</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
