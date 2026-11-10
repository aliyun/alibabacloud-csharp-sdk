// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or <c>RestoreTaskId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0wwwXXXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end of the time range to query restore tasks. Specify the time in the UNIX timestamp format. The timestamp is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361528</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than or equal to 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>The default value is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the restore task. You can specify multiple IDs, separated by commas. You can call the <a href="https://help.aliyun.com/document_detail/2869836.html">CreateRestoreTask</a> operation to obtain the restore task ID.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or <c>BackupPlanId</c>. Specifying both parameters returns an error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s102h7rf5anq</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query restore tasks. Specify the time in the UNIX timestamp format. The timestamp is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361528</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
