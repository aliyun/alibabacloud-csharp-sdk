// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskDetailHistoryRequest : TeaModel {
        /// <summary>
        /// <para>Domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Domain name cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainNameCursor")]
        [Validation(Required=false)]
        public string DomainNameCursor { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Task detail cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75addb07-28a3-450e-b5ec</para>
        /// </summary>
        [NameInMap("TaskDetailNoCursor")]
        [Validation(Required=false)]
        public string TaskDetailNoCursor { get; set; }

        /// <summary>
        /// <para>Job number.</para>
        /// <remarks>
        /// <para>You can obtain the job number by calling the <a href="https://help.aliyun.com/document_detail/67709.html">QueryTaskList</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75addb07-28a3-450e-b5ec-test</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

        /// <summary>
        /// <para>Job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Waiting to execute.</description></item>
        /// <item><description><b>1</b>: Executing.</description></item>
        /// <item><description><b>2</b>: Succeeded.</description></item>
        /// <item><description><b>3</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
