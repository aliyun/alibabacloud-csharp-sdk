// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataCenterTableResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataCenterTableResponseBodyData Data { get; set; }
        public class ListDataCenterTableResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListDataCenterTableResponseBodyDataContent> Content { get; set; }
            public class ListDataCenterTableResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>diamonds.csv</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("DescUpdateTime")]
                [Validation(Required=false)]
                public string DescUpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>69950353</para>
                /// </summary>
                [NameInMap("DmsDbId")]
                [Validation(Required=false)]
                public long? DmsDbId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2310246</para>
                /// </summary>
                [NameInMap("DmsInstanceId")]
                [Validation(Required=false)]
                public long? DmsInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-11T14:04:32.000+00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FILE</para>
                /// </summary>
                [NameInMap("ImportType")]
                [Validation(Required=false)]
                public string ImportType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f-ean8u5881qk4*********xh5y</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("TableDesc")]
                [Validation(Required=false)]
                public string TableDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xa8wib4ga3a2*********fjbx</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>diamonds</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
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
