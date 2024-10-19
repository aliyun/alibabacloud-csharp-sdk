// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsRequest : TeaModel {
        /// <summary>
        /// <para>The specified API ID. This parameter must be specified together with GroupId and StageName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b81fd160f5645e097cc8855d75a1cf6</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The specified group ID. This parameter must be specified together with ApiId and StageName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0009db9c828549768a200320714b8930</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The security token included in the WebSocket request header. The system uses this token to authenticate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>436fa39b-b3b9-40c5-ae5d-ce3e000e38c5</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The environment name. This parameter must be specified together with GroupId and ApiId. Valid values:********</para>
        /// <list type="bullet">
        /// <item><description><b>RELEASE</b></description></item>
        /// <item><description><b>TEST</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RELEASE</para>
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// <para>The ID of the throttling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf123456</para>
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// <para>The name of the throttling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ThrottlingTest</para>
        /// </summary>
        [NameInMap("TrafficControlName")]
        [Validation(Required=false)]
        public string TrafficControlName { get; set; }

    }

}
