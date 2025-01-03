// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserDrawRecordByPkResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListUserDrawRecordByPkResponseBodyData> Data { get; set; }
        public class ListUserDrawRecordByPkResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1401072305438324</para>
            /// </summary>
            [NameInMap("aliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsadsadsadas</para>
            /// </summary>
            [NameInMap("drawGroup")]
            [Validation(Required=false)]
            public string DrawGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dasdsadasdas</para>
            /// </summary>
            [NameInMap("drawPoolName")]
            [Validation(Required=false)]
            public string DrawPoolName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("drawResult")]
            [Validation(Required=false)]
            public string DrawResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1545726028000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("taskGroupId")]
            [Validation(Required=false)]
            public string TaskGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsadsadasd</para>
            /// </summary>
            [NameInMap("uccId")]
            [Validation(Required=false)]
            public string UccId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
