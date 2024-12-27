// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListTriggersRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 0 to 100.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>If the total number of triggers is greater than the value of MaxResults, you must specify NextToken.</para>
        /// <para>You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: DESC.</para>
        /// <list type="bullet">
        /// <item><description>ASC (default): ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: the point in time when the trigger is created.</description></item>
        /// <item><description>UpdateTime: the most recent point in time when the trigger is updated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-11T06:51:17.5Z</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The status of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ready: The trigger is ready.</description></item>
        /// <item><description>Running: The trigger is running.</description></item>
        /// <item><description>Failed: The trigger failed and cannot be automatically recovered.</description></item>
        /// <item><description>Suspended: The trigger is suspended.</description></item>
        /// <item><description>Succeeded: The trigger is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The custom tag. You can specify this parameter only if you specified Tags when you called the CreateTrigger operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test=val1</para>
        /// </summary>
        [NameInMap("TagSelector")]
        [Validation(Required=false)]
        public string TagSelector { get; set; }

    }

}
