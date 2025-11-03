// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeNsasSuspEventTypeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the container field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clusterId</b>: the ID of the cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3108551c83c4d949106e1ab9e1e****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The ID of the request source. Set the value to <b>sas</b>, which indicates that the request is sent from Security Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the accounts that you want to query. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the current account.</description></item>
        /// <item><description><b>1</b>: all accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiAccountActionType")]
        [Validation(Required=false)]
        public int? MultiAccountActionType { get; set; }

        /// <summary>
        /// <para>The name of the alert type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unusual Logon</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testECS</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.212.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>List of supported alarm operation types.</para>
        /// </summary>
        [NameInMap("SupportOperateCodeList")]
        [Validation(Required=false)]
        public List<string> SupportOperateCodeList { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f56406cb-916d-42db-b6f7-2ff79e34****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
