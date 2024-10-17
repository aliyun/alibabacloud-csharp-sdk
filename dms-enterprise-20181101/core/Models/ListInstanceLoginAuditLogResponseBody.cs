// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceLoginAuditLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidPageSize</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter PageSize is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The logon records of the instance.</para>
        /// </summary>
        [NameInMap("InstanceLoginAuditLogList")]
        [Validation(Required=false)]
        public ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList InstanceLoginAuditLogList { get; set; }
        public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList : TeaModel {
            [NameInMap("InstanceLoginAuditLog")]
            [Validation(Required=false)]
            public List<ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog> InstanceLoginAuditLog { get; set; }
            public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog : TeaModel {
                /// <summary>
                /// <para>The database account that is used to log on to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_User</para>
                /// </summary>
                [NameInMap("DbUser")]
                [Validation(Required=false)]
                public string DbUser { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>177****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp144d5ky4l4rli0417****.mysql.rds.aliyuncs.com:3306[rm-bp144d5ky4l4r****]</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The time when the user performed an operation on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-18 11:13:26</para>
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// <para>The source IP address of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>117.36.XX.XX,100.104.XX.XX</para>
                /// </summary>
                [NameInMap("RequestIp")]
                [Validation(Required=false)]
                public string RequestIp { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The alias of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_UserName</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>074CE7C9-4F9C-5B62-89BC-7B4914A3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
