// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchRetcodeAppByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned page information.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchRetcodeAppByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchRetcodeAppByPageResponseBodyPageBean : TeaModel {
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The browser monitoring tasks that are returned.</para>
            /// </summary>
            [NameInMap("RetcodeApps")]
            [Validation(Required=false)]
            public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps> RetcodeApps { get; set; }
            public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeApps : TeaModel {
                /// <summary>
                /// <para>The ID of the application. The parameter is an auto-increment parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16064</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545363321000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The alias of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c1</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The process identifier (PID) of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eb4zdose6v@9781be0f44d****</para>
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
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxyexli2****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>web</c>: web application</description></item>
                /// <item><description><c>weex</c>: Weex mobile app</description></item>
                /// <item><description><c>mini_dd</c>: DingTalk mini program</description></item>
                /// <item><description><c>mini_alipay</c>: Alipay mini program</description></item>
                /// <item><description><c>mini_wx</c>: WeChat mini program</description></item>
                /// <item><description><c>mini_common</c>: mini program on other platforms</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("RetcodeAppType")]
                [Validation(Required=false)]
                public string RetcodeAppType { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<SearchRetcodeAppByPageResponseBodyPageBeanRetcodeAppsTags> Tags { get; set; }
                public class SearchRetcodeAppByPageResponseBodyPageBeanRetcodeAppsTags : TeaModel {
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
                /// <para>RETCODE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the task was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1545363321000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12341234</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>626037F5-FDEB-45B0-804C-B3C92797A64E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
