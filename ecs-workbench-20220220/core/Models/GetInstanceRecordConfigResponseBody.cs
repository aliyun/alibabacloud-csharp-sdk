// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20220220.Models
{
    public class GetInstanceRecordConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParamter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter is null or invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public GetInstanceRecordConfigResponseBodyRoot Root { get; set; }
        public class GetInstanceRecordConfigResponseBodyRoot : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ExpirationDays")]
            [Validation(Required=false)]
            public int? ExpirationDays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:oss:cn-shanghai:123:workbench-record-123-1/record</para>
            /// </summary>
            [NameInMap("RecordStorageTarget")]
            [Validation(Required=false)]
            public string RecordStorageTarget { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
