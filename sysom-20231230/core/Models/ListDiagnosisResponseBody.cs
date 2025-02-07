// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListDiagnosisResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDiagnosisResponseBodyData> Data { get; set; }
        public class ListDiagnosisResponseBodyData : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            [NameInMap("command")]
            [Validation(Required=false)]
            public object Command { get; set; }

            [NameInMap("created_at")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("err_msg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            [NameInMap("params")]
            [Validation(Required=false)]
            public object Params { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public object Result { get; set; }

            [NameInMap("service_name")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("updated_at")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
