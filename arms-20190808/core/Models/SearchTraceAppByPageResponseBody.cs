// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTraceAppByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the array object.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTraceAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTraceAppByPageResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The information about the monitoring task.</para>
            /// </summary>
            [NameInMap("TraceApps")]
            [Validation(Required=false)]
            public List<SearchTraceAppByPageResponseBodyPageBeanTraceApps> TraceApps { get; set; }
            public class SearchTraceAppByPageResponseBodyPageBeanTraceApps : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1531291867000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The aliases of the application.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The process identifier (PID) of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>atc889zkcf@d8deedfa9bf****</para>
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public string Pid { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxyexli2****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is displayed in the Application Real-Time Monitoring Service (ARMS) console. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: yes</description></item>
                /// <item><description><c>false</c>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Show")]
                [Validation(Required=false)]
                public bool? Show { get; set; }

                /// <summary>
                /// <para>A list of tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<SearchTraceAppByPageResponseBodyPageBeanTraceAppsTags> Tags { get; set; }
                public class SearchTraceAppByPageResponseBodyPageBeanTraceAppsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The type of the monitoring task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>TRACE</c>: Application Monitoring</description></item>
                /// <item><description><c>RETCODE</c>: Browser Monitoring</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TRACE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the task information was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1531291867000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113197164949****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B446DF2-3DDD-4B5B-8E3F-D5225120****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
