// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the active version of the recall management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentRecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string CurrentRecallManagementServiceVersionId { get; set; }

        /// <summary>
        /// <para>The name of the active version of the recall management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version-1</para>
        /// </summary>
        [NameInMap("CurrentRecallManagementServiceVersionName")]
        [Validation(Required=false)]
        public string CurrentRecallManagementServiceVersionName { get; set; }

        /// <summary>
        /// <para>The description of the recall management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test recall</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the recall management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hot_group_recall</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the recall management service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecallManagementServiceId")]
        [Validation(Required=false)]
        public string RecallManagementServiceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the recall management service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Online: The service is running and available.</para>
        /// </description></item>
        /// <item><description><para>Offline: The service is stopped or unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
