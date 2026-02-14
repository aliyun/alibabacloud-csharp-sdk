// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataCenterDatabaseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataCenterDatabaseResponseBodyData> Data { get; set; }
        public class ListDataCenterDatabaseResponseBodyData : TeaModel {
            [NameInMap("DatabaseDesc")]
            [Validation(Required=false)]
            public string DatabaseDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>diamonds.csv</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6kv159u9vtpvl**********b8</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>csv</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("DescUpdateTime")]
            [Validation(Required=false)]
            public string DescUpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>73088962</para>
            /// </summary>
            [NameInMap("DmsDbId")]
            [Validation(Required=false)]
            public long? DmsDbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2740966</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IsInternal")]
            [Validation(Required=false)]
            public string IsInternal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

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
