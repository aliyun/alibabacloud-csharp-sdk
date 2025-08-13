// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class BindVariableRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values: </para>
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
        /// <para>API region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("apiRegionId")]
        [Validation(Required=false)]
        public string ApiRegionId { get; set; }

        /// <summary>
        /// <para>API type</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELF</para>
        /// </summary>
        [NameInMap("apiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Associated variable definition primary key ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2438</para>
        /// </summary>
        [NameInMap("defineId")]
        [Validation(Required=false)]
        public string DefineId { get; set; }

        /// <summary>
        /// <para>Variable definition IDs, can be multiple. If binding multiple IDs, separate them with commas</para>
        /// 
        /// <b>Example:</b>
        /// <para>1546, 1547</para>
        /// </summary>
        [NameInMap("defineIds")]
        [Validation(Required=false)]
        public string DefineIds { get; set; }

        /// <summary>
        /// <para>Description information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>变量描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Event code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_agbzfi5134</para>
        /// </summary>
        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>Exception value</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYS_ERROR</para>
        /// </summary>
        [NameInMap("exceptionValue")]
        [Validation(Required=false)]
        public string ExceptionValue { get; set; }

        /// <summary>
        /// <para>Variable primary key ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>106875</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Output field path</para>
        /// 
        /// <b>Example:</b>
        /// <para>BOOLEAN</para>
        /// </summary>
        [NameInMap("outputField")]
        [Validation(Required=false)]
        public string OutputField { get; set; }

        /// <summary>
        /// <para>Output type</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>Binding input parameter information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;accountId&quot;:&quot;accountId&quot;,&quot;mobile&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>Event parameter mapping 2.0, either params or paramsList must not be empty. List, JSON structure</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;eventFieldName&quot;:&quot;accountId&quot;,&quot;required&quot;:false}]</para>
        /// </summary>
        [NameInMap("paramsList")]
        [Validation(Required=false)]
        public string ParamsList { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Variable source</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAF</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Title</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>变量title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
