// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of AI services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AgentlessLlmService")]
        [Validation(Required=false)]
        public int? AgentlessLlmService { get; set; }

        /// <summary>
        /// <para>The number of AI tools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("AgentlessScaAiComponent")]
        [Validation(Required=false)]
        public int? AgentlessScaAiComponent { get; set; }

        /// <summary>
        /// <para>The number of startup items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Autorun")]
        [Validation(Required=false)]
        public int? Autorun { get; set; }

        /// <summary>
        /// <para>The number of scheduled tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Cron")]
        [Validation(Required=false)]
        public int? Cron { get; set; }

        /// <summary>
        /// <para>The number of databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public int? Database { get; set; }

        /// <summary>
        /// <para>The number of kernel modules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Lkm")]
        [Validation(Required=false)]
        public int? Lkm { get; set; }

        /// <summary>
        /// <para>The number of ports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The number of processes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>367</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public int? Process { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of middleware assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112</para>
        /// </summary>
        [NameInMap("Sca")]
        [Validation(Required=false)]
        public int? Sca { get; set; }

        /// <summary>
        /// <para>The number of software assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("Software")]
        [Validation(Required=false)]
        public int? Software { get; set; }

        /// <summary>
        /// <para>The number of accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public int? User { get; set; }

        /// <summary>
        /// <para>The number of websites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65</para>
        /// </summary>
        [NameInMap("Web")]
        [Validation(Required=false)]
        public int? Web { get; set; }

        /// <summary>
        /// <para>The number of web services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Webserver")]
        [Validation(Required=false)]
        public int? Webserver { get; set; }

    }

}
