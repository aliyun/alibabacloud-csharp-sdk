// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOpLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of the operation log.</para>
        /// </summary>
        [NameInMap("OpLogDetails")]
        [Validation(Required=false)]
        public GetOpLogResponseBodyOpLogDetails OpLogDetails { get; set; }
        public class GetOpLogResponseBodyOpLogDetails : TeaModel {
            [NameInMap("OpLogDetail")]
            [Validation(Required=false)]
            public List<GetOpLogResponseBodyOpLogDetailsOpLogDetail> OpLogDetail { get; set; }
            public class GetOpLogResponseBodyOpLogDetailsOpLogDetail : TeaModel {
                /// <summary>
                /// <para>The endpoint of the database instance.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is valid only for database instances of the LocalInstance type.</para>
                /// </description></item>
                /// <item><description><para>This parameter is valid only for operations on the functional modules related to tasks.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:dmstest_prod_database@dmstest.rds">dmstest_prod_database@dmstest.rds</a>... [Test instance]</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The functional module for which the operation log is queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SECURITY_RULE</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>The details of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM <c>orders</c> \n LIMIT 20</para>
                /// </summary>
                [NameInMap("OpContent")]
                [Validation(Required=false)]
                public string OpContent { get; set; }

                /// <summary>
                /// <para>The time when the operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-28 16:45:19</para>
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who performed the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("OpUserId")]
                [Validation(Required=false)]
                public long? OpUserId { get; set; }

                /// <summary>
                /// <para>The ID of the ticket or task.</para>
                /// <remarks>
                /// <para> This parameter is valid only for operations on the functional modules related to tasks and the task management module in system management.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>509****</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22275482072787****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The display name of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_name</para>
                /// </summary>
                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47D56208-DB1D-4FD3-BE32-300E43185488</para>
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
        /// <para>The total number of operation logs that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
