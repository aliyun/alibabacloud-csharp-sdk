// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnRealTimeDeliveryProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration results of the domain name.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListDcdnRealTimeDeliveryProjectResponseBodyContent Content { get; set; }
        public class ListDcdnRealTimeDeliveryProjectResponseBodyContent : TeaModel {
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects> Projects { get; set; }
            public class ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects : TeaModel {
                /// <summary>
                /// <para>The type of the collected logs. Default value: cdn_log_access_l1. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cdn_log_access_l1</b>: access logs of DCDN POPs</description></item>
                /// <item><description><b>cdn_log_origin</b>: back-to-origin logs</description></item>
                /// <item><description><b>cdn_log_er</b>: EdgeRoutine logs</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cdn_log_access_l1</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The region from which logs were collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn</para>
                /// </summary>
                [NameInMap("DataCenter")]
                [Validation(Required=false)]
                public string DataCenter { get; set; }

                /// <summary>
                /// <para>The domain names from which logs were collected. You can specify one or more domain names. Separate multiple domain names with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com,example.org</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the field. For more information about fields in real-time log entries, see <a href="https://help.aliyun.com/document_detail/324199.html">Fields in a real-time log</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>field1,field2</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The name of the Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-cn</para>
                /// </summary>
                [NameInMap("SLSLogStore")]
                [Validation(Required=false)]
                public string SLSLogStore { get; set; }

                /// <summary>
                /// <para>The name of the log file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-cn</para>
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// <para>The region to which logs were delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                /// <summary>
                /// <para>The sampling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SamplingRate")]
                [Validation(Required=false)]
                public float? SamplingRate { get; set; }

                /// <summary>
                /// <para>The type of log delivery. Only <b>SLS_POST</b> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SLS_POST</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3EACD23C-F49F-4BF7-B9AD-C2CD3BA888C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
